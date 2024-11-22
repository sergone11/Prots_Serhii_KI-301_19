package lab6;

import java.util.ArrayList;

public class Safe<T extends Jewelry> {

    private ArrayList<T> storage = new ArrayList();
    
    public T get(int index)
    {
        try{
            return storage.get(index);
        }
        catch (Exception e)
        {
            throw e;
        }
    }
    
    public void add(T item)
    {
        try {
            storage.add(item);
        }
        catch (Exception e)
        {
            throw e;
        }
    }
    
    public void showAll()
    {
        for(int i = 0; i < storage.size(); i++)
        {
            try{
                storage.get(i).printData();
            }
            catch (Exception e)
            {
                System.out.println(e);
            }
        }
    }
    
    public int getTotalMass()
    {
        int result = 0;
        for(int i = 0; i < storage.size(); i++)
        {
            result += storage.get(i).getWeight();
        }
        return result;
    }
    
    public T getLargestStore()
    {
        int largestIdx = 0;

        for(int i = 0; i < storage.size(); i++)
        {
            if(i == 0)
            {
                continue;
            }
            if(storage.get(i).getWeight() > storage.get(largestIdx).getWeight())
            {
                largestIdx = i;
            }
        }
        return storage.get(largestIdx);
    }
}
