package lab2;


import java.io.File;
import java.io.PrintWriter;
import java.util.ArrayList;


public class Printer {

    PrintWriter fout;
    private String file = "lab2.txt";

    lab2.PaperBank paperBank = new lab2.PaperBank();
    lab2.Cartridge cartridge;
    ArrayList<lab2.Paper> output = new ArrayList<>();
    
    public Printer() throws Exception
    {
        fout = new PrintWriter(new File(file));
        cartridge = new lab2.Cartridge(new lab2.Color("BLACK"));
    }
    
    public void printText(String text) throws Exception
    {
        printMessage("Printing: " + text);
        Paper paper = paperBank.getPaper();
        paper.printText(text);
        cartridge.print();
        output.add(paper);
    }
    
    public Paper getPaper() throws Exception
    {
        if(output.size() == 0)
        {
            throw new Exception("No papers in output!");
        }

        Paper paper = output.get(output.size() - 1);

        printMessage("Paper content: " + paper.getText());
        return paper;
    }
    
    public void addPapers(int count) throws Exception
    {

        printMessage("Adding " + count + " papers...");
        paperBank.putPapers(count);
    }
    
    public void dispose()
    {
        fout.flush();
        fout.close();
    }
    
    public void changeCartridge(Color color)
    {
        printMessage("Changing the cartridge");
        cartridge = new Cartridge(color);
    }
    
    public void refuelCartridge()
    {
        printMessage("Refueling the cartridge");
        cartridge.refuel();
    }
    
    public int getRemainPaint()
    {
        printMessage("Remain paint: " + cartridge.getRemainPaint());

        return cartridge.getRemainPaint();
    }
    
    public void clearCartridge()
    {
        printMessage("Cleaning the cartridge");
        cartridge.clear();
    }
    
    public int getCartridgePollution()
    {
        printMessage("Cartridge pollution: " + cartridge.getPollution());
        return cartridge.getPollution();
    }

    private void printMessage(String message)
    {
        System.out.println(message);
        fout.println(message);
    }

}
