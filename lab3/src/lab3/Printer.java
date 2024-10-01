package lab3;

import java.io.File;
import java.io.PrintWriter;
import java.util.ArrayList;

// Абстрактний клас Printer, який визначає загальні функції для принтерів
public abstract class Printer {

    
    PrintWriter fout;
    
    private String file = "lab3.txt";

    // Об'єкт PaperBank, що управляє папером
    PaperBank paperBank = new PaperBank();
    
    Cartridge cartridge;
    
    ArrayList<Paper> output = new ArrayList<>();

    // Конструктор класу Printer
    public Printer() throws Exception {
        // Ініціалізація PrintWriter для запису у файл
        fout = new PrintWriter(new File(file));
        // Ініціалізація картриджа з кольором "ЧОРНИЙ"
        cartridge = new Cartridge(new Color("BLACK"));
    }

    
    public void printText(String text) throws Exception {
        
        printMessage("Printing: " + text);
        
        Paper paper = paperBank.getPaper();
        
        paper.printText(text);
        
        cartridge.print();
        
        output.add(paper);
    }

    // Метод для отримання останнього надрукованого паперу
    public Paper getPaper() throws Exception {
        // Перевірка, чи є надрукований папір
        if (output.size() == 0) {
            throw new Exception("No papers in output!");
        }

        // Отримання останнього надрукованого паперу
        Paper paper = output.get(output.size() - 1);

        
        printMessage("Paper content: " + paper.getText());
        return paper;
    }

    // Метод для додавання паперу в PaperBank
    public void addPapers(int count) throws Exception {
        
        printMessage("Adding " + count + " papers...");
        
        paperBank.putPapers(count);
    }

    // Метод для закриття PrintWriter
    public void dispose() {
        fout.flush(); // Завершення запису в файл
        fout.close(); // Закриття 
    }

    // Метод для зміни картриджа на інший колір
    public void changeCartridge(Color color) {
        printMessage("Changing the cartridge");
        // Створення нового картриджа з новим кольором
        cartridge = new Cartridge(color);
    }

    // Метод для перезаправлення картриджа
    public void refuelCartridge() {
        printMessage("Refueling the cartridge");
        
        cartridge.refuel();
    }

    
    public int getRemainPaint() {
        printMessage("Remain paint: " + cartridge.getRemainPaint());
        
        return cartridge.getRemainPaint();
    }

    // Метод для очищення картриджа
    public void clearCartridge() {
        printMessage("Cleaning the cartridge");
        
        cartridge.clear();
    }

    // Метод для отримання рівня забруднення картриджа
    public int getCartridgePollution() {
        printMessage("Cartridge pollution: " + cartridge.getPollution());
        
        return cartridge.getPollution();
    }

    
    private void printMessage(String message) {
        System.out.println(message); // Виведення на консоль
        fout.println(message); // Запис у файл
    }
}
