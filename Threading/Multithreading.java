public class Multithreading
{
    public static void main(String [] args)
    {   
        // for(int i = 0 ; i <= 3 ; i++)
        // {
        //     MultithreadThing myThing = new MultithreadThing(i);
        //     myThing.start();
        // }
        MultithreadThing myThing = new MultithreadThing();
        MultithreadThing myThing1 = new MultithreadThing();
        // myThing.start();
        // myThing1.start();

        myThing.run();
        myThing1.run();
    }
}