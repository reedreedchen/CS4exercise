using System;


class MyEventArg : EventArgs
{
    public int EventNum;
    public int n;
}

class MyEvent
{
    // public delegate void MyEventHandler(object senders, MyEventArg e);
    EventHandler<MyEventArg>[] events = new EventHandler<MyEventArg>[3];

    public event EventHandler<MyEventArg> SomeEvent{
        add {
            for(int i = 0; i < 3; i++)
            {
                try
                {
                    if (events[i] == null) {
                        events[i] = value;
                        if(events[i] == value)
                            Console.WriteLine("ok");
                        break;
                    }
                    //if (i == 3) throw new IndexOutOfRangeException();
                }
                catch (IndexOutOfRangeException exc)
                {
                 //   Console.WriteLine(exc.Message);
                    Console.WriteLine("event is full");
                }
            }


        }
        remove {
            for (int i = 0; i < 3; i++)
            {
                if (events[i] == value)
                {
                    events[i] = null;
                    break;
                }
            }
            Console.WriteLine("removed");
        }
    }

    //public event MyEventHandler SomeEvent2;

    public int OnSomeEvent(int n)//event series execution
    {
        MyEventArg arg = new MyEventArg();
        arg.n = n;
        try
        {
            for (int i = 0; i < 3; i++)
            {
                if(events[i] != null) arg.EventNum++;
                events[i](this, arg);
            }
        }
        catch (NullReferenceException exc)
        {
            Console.WriteLine("1:" + exc.Message);

            /*
            try
            {
                SomeEvent2();
            }
            catch(NullReferenceException exc2)
            {
                Console.WriteLine("2: " + exc2.Message);
            }*/
        }
        return 1;
    }
}

class EventDemo {

    public void Handler(object senders, MyEventArg e)
    {
        Console.WriteLine("Sender" + senders);
        Console.WriteLine("Args" + e.EventNum);
        Console.WriteLine("Event1 Occurred" + e.n);
    }
    public void Handler2(int n)
    {
        Console.WriteLine("Handler2 Occurred");
    }
    public void Handler3(int n)
    {
        Console.WriteLine("Handler3 Occurred");
    }
    public void Handler4(int n)
    {
        Console.WriteLine("Handler4 Occurred");
    }
}


