// AdvancedHelloWorld.cs
using System;

namespace SimplePrograms {
  class AdvancedHelloWorld {
    // Variables
    static bool all_caps = false;
    static bool all_lower_case = false;
    static bool interleaved = false;
    static bool exclamation = false;

    // Main
    static void Main(string[] args) {
      ParseArgs(args);
      PrintHelloWorld();
    }

    // ParseArgs Helper Method
    private static void ParseArgs(string[] args) {
      for (int i = 0; i < args.Length; i++) {
        if (args[i] == "--help") {System.Console.WriteLine("We don't offer help here.");}
        else if ( args[i] == "--allcaps" || args[i] == "-a" ) {
          all_caps = true;
          all_lower_case = false;
          interleaved = false;
        }
        else if ( args[i] == "--lowercase" || args[i] == "-l" ) {
          all_caps = false;
          all_lower_case = true;
          interleaved = false;
        }
        else if ( args[i] == "--interleaved" || args[i] == "-i" ) {
          all_caps = false;
          all_lower_case = false;
          interleaved = true;
        }
        else if ( args[i] == "--exclamation" || args[i] == "-e" ) {
          exclamation = true;
        }
      }
    }

    // PrintHelloWorld Helper Method
    private static void PrintHelloWorld() {
        string output = "";
        if ( all_caps ) { output += "HELLO WORLD"; }
        else if ( all_lower_case ) { output += "hello world"; }
        else if ( interleaved ) { output += "HeLlO wOrLd"; }
        else { output += "Hello World"; }
        if ( exclamation ) { output += "!"; }
        System.Console.WriteLine(output);
    }
  }
}
