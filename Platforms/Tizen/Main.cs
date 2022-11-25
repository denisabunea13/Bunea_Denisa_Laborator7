using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Bunea_Denisa_Laborator7;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
