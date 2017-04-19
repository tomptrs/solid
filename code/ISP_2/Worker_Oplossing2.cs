using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2_2
{
    //FAVOR COMPOSITION OVER INHERITANCE!

    interface IWorkable
    {
        void work();
    }

    interface IFeedable
    {
        void eat();
    }

    class Worker : IWorkable, IFeedable
    {
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
        public WorkAlgorithm DoeWerk { get; set; }
        public void work()
        {
            // ....working
            DoeWerk.DoWork();
        }
    }

    class SuperWorker : IWorkable, IFeedable
    {
        public WorkAlgorithm DoeWerk { get; set; }
        public void work()
        {
            DoeWerk.DoWork();
        }

        public void eat()
        {
            //.... eating in launch break
        }
    }
    abstract class WorkAlgorithm
    {
        public abstract void DoWork();
    }
    class WorkAlgorithmAlgemeen:WorkAlgorithm
    {
        public override void DoWork()
        {
           //WORK
           //EAT
        }
    }
    class WorkAlgoZonderEten : WorkAlgorithm
    {
        public override void DoWork()
        {
            //Only Work
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
