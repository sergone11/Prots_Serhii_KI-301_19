package lab3;

public class Color {

	    String color;
	    
	    public Color(String color) throws Exception
	    {
	        if(!isValid(color))
	        {
	            throw new Exception("Color is invalid!");
	        }

	        this.color = color;
	    }

	    private boolean isValid(String color)
	    {
	        if(!color.equals("BLACK") && !color.equals("BLUE") && !color.equals("YELLOW") && !color.equals("RED"))
	        {
	            return false;
	        }
	        return true;
	    }
	}

