﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Peace
{
    [TestClass]
    class UnitTest
    {

        [TestMethod]
        public void Run()
        {

        }
        //ChineseSpeaker 同上面的代码一样
        #region Constructor Injection
        //public class Printer
        //{
        //    private ISpeak _speak;
        //    public Printer(ISpeak speak)//构造函数注入
        //    {
        //        _speak = speak;
        //    }
        //}

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        //ChineseSpeaker chineseSpeaker = new ChineseSpeaker();
        //        //chineseSpeaker.SayHello();
        //        //BritishSpeaker britishSpeaker = new BritishSpeaker();
        //        //britishSpeaker.SayHello();

        //        //ISpeak speak;

        //        //if (args.Length > 0 && args[0] == "Chinese")
        //        //{
        //        //    speak = new ChineseSpeaker();
        //        //}
        //        //else
        //        //{
        //        //    speak = new BritishSpeaker();
        //        //}

        //        //speak.SayHello();

        //        Printer print;

        //        if (args.Length > 0 && args[0] == "Chinese")
        //        {
        //            print = new Printer(new ChineseSpeaker());
        //        }
        //        else
        //        {
        //            print = new Printer(new BritishSpeaker());
        //        }

        //    }
        //}

        #endregion

        #region Property Injection

        //public class Printer
        //{
        //    public ISpeak Speaker { get; set; }
        //}

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        //ChineseSpeaker chineseSpeaker = new ChineseSpeaker();
        //        //chineseSpeaker.SayHello();
        //        //BritishSpeaker britishSpeaker = new BritishSpeaker();
        //        //britishSpeaker.SayHello();

        //        //ISpeak speak;

        //        //if (args.Length > 0 && args[0] == "Chinese")
        //        //{
        //        //    speak = new ChineseSpeaker();
        //        //}
        //        //else
        //        //{
        //        //    speak = new BritishSpeaker();
        //        //}

        //        //speak.SayHello();

        //        Printer print = new Printer();
        //        if (args.Length > 0 && args[0] == "Chinese")
        //        {
        //            print.Speaker = new ChineseSpeaker();
        //        }
        //        else
        //        {
        //            print.Speaker = new BritishSpeaker();
        //        }
        //    }
        //}


        #endregion

        #region Interface Injection

        //接口注入
        public interface IPrint
        {
            void SetSpeaker(ISpeak speak);
        }

        public class Printer : IPrint
        {
            private ISpeak _speak;
            public void SetSpeaker(ISpeak speak)
            {
                _speak = speak;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                //ChineseSpeaker chineseSpeaker = new ChineseSpeaker();
                //chineseSpeaker.SayHello();
                //BritishSpeaker britishSpeaker = new BritishSpeaker();
                //britishSpeaker.SayHello();

                ISpeak speak;

                if (args.Length > 0 && args[0] == "Chinese")
                {
                    speak = new ChineseSpeaker();
                }
                else
                {
                    speak = new BritishSpeaker();
                }

                Printer printer = new Printer();
                printer.SetSpeaker(speak);
            }
        }


        #endregion


        public interface ISpeak
        {
            void SayHello();
        }

        public class BritishSpeaker : ISpeak
        {
            public void SayHello()
            {
                Console.WriteLine("Hello!!!");
            }
        }

        public class ChineseSpeaker : ISpeak
        {
            public void SayHello()
            {
                Console.WriteLine("你好！！！");
            }
        }


    }
}
