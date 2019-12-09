using System;

namespace DesignPatterns.Chain_Of_Responsibilty
{
    public interface Chain
    {
        void setNext(Chain nextInChain);
        void process(Number request);
    }

    public class Number
    {
        private int number;

        public Number(int number)
        {
            this.number = number;
        }

        public int getNumber()
        {
            return number;
        }
    }

    public class NegativeProcessor : Chain
    {
        private Chain nextInChain;

        public void setNext(Chain c)
        {
            nextInChain = c;
        }

        public void process(Number request)
        {
            if (request.getNumber() < 0)
            {
                Console.WriteLine("NegativeProcessor: " + request.getNumber());
            }
            else
            {
                nextInChain.process(request);
            }
        }
    }

    public class ZeroProcessor : Chain
    {
        private Chain nextInChain;

        public void setNext(Chain c)
        {
            nextInChain = c;
        }

        public void process(Number request)
        {
            if (request.getNumber() == 0)
            {
                Console.WriteLine("ZeroProcessor: " + request.getNumber());
            }
            else
            {
                nextInChain.process(request);
            }
        }
    }

    public class PositiveProcessor : Chain
    {
        private Chain nextInChain;

        public void setNext(Chain c)
        {
            nextInChain = c;
        }

        public void process(Number request)
        {
            if (request.getNumber() > 0)
            {
                Console.WriteLine("PositiveProcessor: " + request.getNumber());
            }
            else
            {
                nextInChain.process(request);
            }
        }
    }
}