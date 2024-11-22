from equations import Equations
from wfile import WFile


def main():
    f_name = input("Enter the name of the file to save the res: ")
    try:
        x = float(input("Enter X: "))

        # Обчислення результату
        equations = Equations()
        res = equations.calculate(x)

        # Запис результату у файл і читання
        wfile = WFile(f_name)
        wfile.writeResTxt(str(res))
        wfile.writeResBin(str(res))

        # Виведення результату з файлів
        read_result = wfile.readResBin()
        read_result1 = wfile.readResTxt()
        print("Res from file:", read_result)
        print("Res from file:", read_result1)
    except ValueError:
        print("Error: The entered X must be a number")


# Запускаємо main функцію, якщо цей файл виконується напряму
if __name__ == "__main__":
    main()
