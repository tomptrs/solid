using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2_TMP
{
    // interface segregation principle - good example


interface IWorkable
{
     void work();
}

interface IFeedable
{
     void eat();
}

class Worker : IWorkable, IFeedable{
	public void work()
{
    // ....working
}

public void eat()
{
    //.... eating in launch break
}
}

class Robot : IWorkable
{

    public void work()
{
    // ....working
}
}

class SuperWorker : IWorkable, IFeedable{
	public void work()
{
    //.... working much more
}

public void eat()
{
    //.... eating in launch break
}
}

class Manager
{
    IWorkable worker;

    public void setWorker(IWorkable w)
    {
        worker = w;
    }

    public void manage()
    {
        worker.work();

            if (worker is SuperWorker)
            {
                ((SuperWorker)worker).eat();
            }
    }
}

    public class tmp
    {
        void doe()
        {
            IWorkable r = new Robot();
            IWorkable w = new Worker();
            Manager m = new Manager();


            m.setWorker(r);
            m.setWorker(w);

            //I'm hungry..

           
        }
    }
}
