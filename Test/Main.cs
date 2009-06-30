// 
// Main.cs
//  
// Author:
//       Joshua Simmons <simmons.44@gmail.com>
// 
// Copyright (c) 2009 Joshua Simmons
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

/// <summary>
/// This will serve as a testing platform, and example usage of the LuaSharp library.
/// If you are looking for example usage of the low level wrapper, check out the LuaSharp class code.
/// </summary>

using System;
using LuaSharp;

namespace Test
{
	class MainClass
	{		
		public static void Main(string[] args)
		{
			try
			{
				LuaState s = new LuaState();
				
				// Create a table and set one of its members via dostring.
				//s.DoString( "func = function( a, b, c ) print( a, b, c ) return \"aaa\", \"bbb\" end" );
				
				LuaFunction f1 = s["print"] as LuaFunction;
				LuaFunction f2 = s["print"] as LuaFunction;
				
				// Grab the value set from the global environment.
				//foreach( object str in f1.Call( "uno", "two", 99, 9001, "fasf", f1 ) )
				//{
				//	Console.WriteLine( str );
				//}
			}
			catch( LuaException e )
			{
				Console.WriteLine( "LolFail: " + e.Message + "\n\n" + e.StackTrace );
			}
		}			
	}
}