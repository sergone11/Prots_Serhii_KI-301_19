package lab2;

public class PaperBank {


    int papers;
    int MAX_COUNT = 100;

    
    public PaperBank()
    {
        this.papers = MAX_COUNT; // Спочатку банк містить максимальну кількість паперу (100 аркушів)
    }
    
    public void putPapers(int count) throws Exception
    {
        if(count > MAX_COUNT)
        {
            throw new Exception("Too many papers!");
        }

        this.papers = count;
    }
    
    public Paper getPaper() throws Exception
    {
        if(papers == 0)
        {
            throw new Exception("No paper!");
        }

        papers -= 1;

        return new Paper();
    }

}
