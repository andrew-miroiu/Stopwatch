using System;

public class CountdownViewModel
{
    private int seconds = 1;
    private int minutes = 1;
    private int hours = 1;

    public int Seconds
    {
        get
        {
            return seconds;
        }

        set
        {
            seconds = value;
        }
    }

    public int Minutes
    {
        get
        {
            return minutes;
        }

        set
        {
            minutes = value;
        }
    }

    public int Hours
    {
        get
        {
            return hours;
        }

        set
        {
            hours = value;
        }
    }

}
