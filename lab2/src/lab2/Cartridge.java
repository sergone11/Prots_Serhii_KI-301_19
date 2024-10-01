package lab2;

public class Cartridge {

    private Color color;
    private int remainPaint = 100;
    private int pollutionValue = 0;
    private int MAX_POLLUTION = 100;
    
    public Cartridge(Color color)
    {
        this.color = color;
    }
    
    public void print() throws Exception
    {
    	// Якщо картридж максимально забруднений, викидається виняток
    	
        if(MAX_POLLUTION == pollutionValue)
        {
            throw new Exception("Cartridge is polluted!");
        }

        remainPaint -= 1;
    }
    
    public void refuel()
    {
        remainPaint = 100;
    }
    
    public int getRemainPaint()
    {
        return remainPaint;
    }
    
    public void clear()
    {
        pollutionValue = 0;
    }
    
    public int getPollution()
    {
        return pollutionValue;
    }
}
