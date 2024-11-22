using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CarServiceServer
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 12345; // Port for listening
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1"); // Local IP address

            TcpListener server = new TcpListener(ipAddress, port);

            // Start the server
            server.Start();
            Console.WriteLine($"Server started on IP {ipAddress} and port {port}");

            // Main loop for handling connections
            while (true)
            {
                Console.WriteLine("Waiting for a connection...");

                // Accept connection from client
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Connection accepted.");

                // Handle client connection in a separate task
                Task.Run(() => HandleClient(client));
            }
        }

        private static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();

            // Read data from client
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string clientMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            Console.WriteLine($"Message from client: {clientMessage}");

            // Split client message into parts
            string[] messageParts = clientMessage.Split(',');

            if (messageParts.Length == 7)
            {
                // If the message contains 7 parts (first name, last name, car make, car model, phone, username, password)
                string firstName = messageParts[0];
                string lastName = messageParts[1];
                string carMake = messageParts[2];
                string carModel = messageParts[3];
                string phone = messageParts[4];
                string username = messageParts[5];
                string password = messageParts[6];

                // Add user to database
                if (AddUserToDatabase(firstName, lastName, carMake, carModel, phone, username, password))
                {
                    Console.WriteLine("User successfully registered.");
                    SendResponseToClient(stream, "Registration successful.");
                }
                else
                {
                    Console.WriteLine("Error registering user.");
                    SendResponseToClient(stream, "Registration failed.");
                }
            }
            else if (messageParts.Length == 2)
            {
                // Handle login (username, password)
                string username = messageParts[0];
                string password = messageParts[1];

                if (VerifyUserCredentials(username, password))
                {
                    Console.WriteLine("Login successful.");
                    SendResponseToClient(stream, "Login successful.");
                }
                else
                {
                    Console.WriteLine("Invalid login or password.");
                    SendResponseToClient(stream, "Invalid login or password.");
                }
            }
            else if (messageParts.Length == 5)
            {
                // Handle repair booking (client name, car model, repair date, repair time, problem description)
                string clientName = messageParts[0];
                string carModel = messageParts[1];
                string repairDate = messageParts[2];
                string repairTime = messageParts[3];
                string problemDescription = messageParts[4];

                // Add repair booking to the database
                if (AddRepairBookingToDatabase(clientName, carModel, repairDate, repairTime, problemDescription))
                {
                    Console.WriteLine("Repair booking successfully added.");
                    SendResponseToClient(stream, "Repair booking successful.");
                }
                else
                {
                    Console.WriteLine("Error booking repair.");
                    SendResponseToClient(stream, "Repair booking failed.");
                }
            }
            else if (messageParts.Length == 5)
            {
                // Handle maintenance booking (client name, car model, maintenance date, maintenance time, maintenance type)
                string clientName = messageParts[0];
                string carModel = messageParts[1];
                string maintenanceDate = messageParts[2];
                string maintenanceTime = messageParts[3];
                string maintenanceType = messageParts[4];

                // Add maintenance booking to the database
                if (AddMaintenanceBookingToDatabase(clientName, carModel, maintenanceDate, maintenanceTime, maintenanceType))
                {
                    Console.WriteLine("Maintenance booking successfully added.");
                    SendResponseToClient(stream, "Maintenance booking successful.");
                }
                else
                {
                    Console.WriteLine("Error booking maintenance.");
                    SendResponseToClient(stream, "Maintenance booking failed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid message format.");
                SendResponseToClient(stream, "Invalid data format.");
            }

            // Close connection
            client.Close();
            Console.WriteLine("Connection closed.");
        }

        private static void SendResponseToClient(NetworkStream stream, string responseMessage)
        {
            byte[] responseData = Encoding.UTF8.GetBytes(responseMessage);
            stream.Write(responseData, 0, responseData.Length);
        }

        // Function to add user to the database
        private static bool AddUserToDatabase(string firstName, string lastName, string carMake, string carModel, string phone, string username, string password)
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=CarServiceDB;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to add user
                    string query = "INSERT INTO Users (FirstName, LastName, CarMake, CarModel, Phone, Username, Password) VALUES (@FirstName, @LastName, @CarMake, @CarModel, @Phone, @Username, @Password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to query
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@CarMake", carMake);
                        command.Parameters.AddWithValue("@CarModel", carModel);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password); // Store the password as plain text

                        int result = command.ExecuteNonQuery();

                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to database: {ex.Message}");
                return false;
            }
        }

        // Function to verify user credentials (login)
        private static bool VerifyUserCredentials(string username, string enteredPassword)
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=CarServiceDB;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to get stored password for the user
                    string query = "SELECT Password FROM Users WHERE Username = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        string storedPassword = (string)command.ExecuteScalar(); // Get the stored password

                        if (storedPassword == null)
                        {
                            Console.WriteLine("User not found.");
                            return false;
                        }

                        // Compare the entered password with the stored password
                        if (storedPassword == enteredPassword)
                        {
                            return true; // Successful login
                        }
                        else
                        {
                            return false; // Incorrect password
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to database: {ex.Message}");
                return false;
            }
        }

        // Function to add repair booking to the database
        private static bool AddRepairBookingToDatabase(string clientName, string carModel, string repairDate, string repairTime, string problemDescription)
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=CarServiceDB;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to add repair booking
                    string query = "INSERT INTO RepairBookings (ClientName, CarModel, RepairDate, RepairTime, ProblemDescription) VALUES (@ClientName, @CarModel, @RepairDate, @RepairTime, @ProblemDescription)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to query
                        command.Parameters.AddWithValue("@ClientName", clientName);
                        command.Parameters.AddWithValue("@CarModel", carModel);
                        command.Parameters.AddWithValue("@RepairDate", repairDate);
                        command.Parameters.AddWithValue("@RepairTime", repairTime);
                        command.Parameters.AddWithValue("@ProblemDescription", problemDescription);

                        int result = command.ExecuteNonQuery();

                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to database: {ex.Message}");
                return false;
            }
        }

        // Function to add maintenance booking to the database
        private static bool AddMaintenanceBookingToDatabase(string clientName, string carModel, string maintenanceDate, string maintenanceTime, string maintenanceType)
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=CarServiceDB;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to add maintenance booking
                    string query = "INSERT INTO MaintenanceTable (ClientName, CarModel, MaintenanceDate, MaintenanceTime, MaintenanceType) VALUES (@ClientName, @CarModel, @MaintenanceDate, @MaintenanceTime, @MaintenanceType)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to query
                        command.Parameters.AddWithValue("@ClientName", clientName);
                        command.Parameters.AddWithValue("@CarModel", carModel);
                        command.Parameters.AddWithValue("@MaintenanceDate", maintenanceDate);
                        command.Parameters.AddWithValue("@MaintenanceTime", maintenanceTime);
                        command.Parameters.AddWithValue("@MaintenanceType", maintenanceType);

                        int result = command.ExecuteNonQuery();

                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to database: {ex.Message}");
                return false;
            }
        }
    }
}
