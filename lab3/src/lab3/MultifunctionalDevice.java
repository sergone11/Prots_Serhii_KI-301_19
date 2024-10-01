package lab3;

	interface IMultifunctionalDevice{
	    void scan(Paper paper);
	    void printScanned() throws Exception;
	}

	public class MultifunctionalDevice extends Printer implements IMultifunctionalDevice {

	    private String dataStorage;

	    
	    public MultifunctionalDevice() throws Exception {
	    }

	    
	    public void scan(Paper paper) {
	        dataStorage = paper.getText();
	    }

	    
	    public void printScanned() throws Exception {
	        super.printText(dataStorage);
	    }
	}

