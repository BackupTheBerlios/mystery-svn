using System;
using System.Text;
using Engine.Core;
using Engine.Core.Math;

namespace Test
{
	class Program
	{
        public MEngine me = new MEngine();

		private Vector3 v1;
		private Vector3 v2;
		private Vector3 v3;
       

		public Program()
		{
			v1 = Vector3Manipulation.Zero();
			v2 = Vector3Manipulation.Zero();
			v3 = Vector3Manipulation.Zero();

			v1 = new Vector3(27, 45, 23);
			v2 = new Vector3(17, 35, 15);
            //Image_Loader.Get_CopyRight();
			
            me.Initialize_Engine(MEngine.Init_Flags.Graphics);
            me.Platmgr.CreateWindow("MysteryEngine Window", "icon.bmp", 800, 600, 32, false, true);

            me.Platmgr.Setup();
            me.Renderer.Setup();

		}
		static void Main(string[] args)
		{
			Program pro = new Program();

			pro.v3 = pro.v1 + pro.v2;

			Console.WriteLine("First Vector \n");
			Console.WriteLine("X: {0} , Y: {1} , Z: {2} \n", pro.v1.x, pro.v1.y, pro.v1.z);
			Console.WriteLine("Plus \n \n Second Vector \n");
			Console.WriteLine("X: {0} , Y: {1} , Z: {2} \n", pro.v2.x, pro.v2.y, pro.v2.z);
			Console.WriteLine("Equals \n \n Third Vector \n");
			Console.WriteLine("X: {0} , Y: {1} , Z: {2} \n", pro.v3.x, pro.v3.y, pro.v3.z);

			pro.v3 = pro.v1 - pro.v2;

			Console.WriteLine("First Vector \n");
			Console.WriteLine("X: {0} , Y: {1} , Z: {2} \n", pro.v1.x, pro.v1.y, pro.v1.z);
			Console.WriteLine("Minus \n \n Second Vector \n");
			Console.WriteLine("X: {0} , Y: {1} , Z: {2} \n", pro.v2.x, pro.v2.y, pro.v2.z);
			Console.WriteLine("Equals \n \n Third Vector \n");
			Console.WriteLine("X: {0} , Y: {1} , Z: {2} \n", pro.v3.x, pro.v3.y, pro.v3.z);

			pro.v3 = -pro.v1;

			Console.WriteLine("First Vector \n");
			Console.WriteLine("X: {0} , Y: {1} , Z: {2} \n", pro.v1.x, pro.v1.y, pro.v1.z);
			Console.WriteLine("\n Unary Minus \n");
			Console.WriteLine("Equals \n \n Third Vector \n");
			Console.WriteLine("X: {0} , Y: {1} , Z: {2} \n", pro.v3.x, pro.v3.y, pro.v3.z);

			pro.v3 = pro.v1 * 5;

			Console.WriteLine("First Vector \n");
			Console.WriteLine("X: {0} , Y: {1} , Z: {2} \n", pro.v1.x, pro.v1.y, pro.v1.z);
			Console.WriteLine("Times \n \n Five \n");
			Console.WriteLine("Equals \n \n Third Vector \n");
			Console.WriteLine("X: {0} , Y: {1} , Z: {2} \n", pro.v3.x, pro.v3.y, pro.v3.z);

			
			Console.WriteLine("First Vector \n");
			Console.WriteLine("X: {0} , Y: {1} , Z: {2} \n", pro.v1.x, pro.v1.y, pro.v1.z);
			Console.WriteLine("Magnitude {0}", Vector3Manipulation.FindMagnitude(pro.v2));

			pro.v3 = pro.v1 / 5;
			Console.WriteLine("First Vector Divided by 5: X: {0}, Y: {1}, Z: {2}", pro.v3.x, pro.v3.y, pro.v3.z);

			pro.v1.x = 1;
			pro.v1.y = 3;
			pro.v1.z = -4;

			pro.v2.x = 2;
			pro.v2.y = -5;
			pro.v2.z = 8;

			pro.v3 = Vector3Manipulation.CrossProduct(pro.v1, pro.v2);

			Console.WriteLine("X: {0}, Y: {1}, Z: {2}", pro.v3.x, pro.v3.y, pro.v3.z);

            pro.me.Renderer.ClearScreen(390);

            while (true)
            {
               
                pro.me.Platmgr.GlSwapBuffers();
            }
        }
	}
}
