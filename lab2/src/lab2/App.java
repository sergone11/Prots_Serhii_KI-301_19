package lab2;

public class App {

    
    public static void main(String[] args) throws Exception
    {
    	// Створюємо об'єкт класу Printer з пакету lab2
        lab2.Printer printer = new lab2.Printer();

        printer.printText("test");
        
        // Викликаємо метод, що отримує стан паперу в принтері
        
        printer.getPaper();

        printer.getRemainPaint();

        printer.getCartridgePollution();

        printer.addPapers(1);

        printer.dispose();
    }
}
