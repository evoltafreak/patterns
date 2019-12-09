using System;
using DesignPatterns;
using DesignPatterns.Chain_Of_Responsibilty;
using NUnit.Framework;

namespace DesignPatternsTests.Chain_Of_Responsibilty
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestChainOfResponsibility()
        {
            Chain c1 = new NegativeProcessor(); 
            Chain c2 = new ZeroProcessor(); 
            Chain c3 = new PositiveProcessor(); 
            c1.setNext(c2); 
            c2.setNext(c3); 
  
            //calling chain of responsibility 
            c1.process(new Number(90)); 
            c1.process(new Number(-50)); 
            c1.process(new Number(0)); 
            c1.process(new Number(91)); 
        }
        
    }
}