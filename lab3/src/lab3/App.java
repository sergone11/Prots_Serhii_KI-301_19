package lab3;
public class App {
    
	
    public static void main(String[] args) throws Exception
    {
        MultifunctionalDevice device = new MultifunctionalDevice();

        device.printText("Text for test");

        Paper paper = device.getPaper();

        device.getRemainPaint();

        device.getCartridgePollution();

        device.addPapers(1);

        device.scan(paper);

        device.printScanned();

        device.dispose();
    }
}

