using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2
{
    // interface segregation principle - bad example
    interface IWorker
    {
         void work();
         void eat();
    }

    class Worker : IWorker
    {

    public void work()
    {
        // ....working
    }
    public void eat()
    {
        // ...... eating in launch break
    }
}

class SuperWorker : IWorker
{

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
    IWorker worker;

    public void setWorker(IWorker w)
    {
        worker = w;
    }

    public void manage()
    {
        worker.work();
    }
}
}
