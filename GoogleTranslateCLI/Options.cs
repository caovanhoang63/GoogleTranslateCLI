using System.ComponentModel.Design;
using CommandLine;
namespace GoogleTranslateCLI;

public class Options
{
    [Option('s', "sourceLanguage",Default = "en", Required = false, HelpText = "source language")]
    public string sourceLanguage { get; set; }

    [Option('t', "targetLanguage",Default = "vi",Required = false, HelpText = "target language")]
    public string targetLanguage { get; set; }
    
    [Option('q', "query", Required = false, HelpText = "query")]
    public string query { get; set; }
    [Value(0, MetaName = "query", HelpText = "Query text")]
    public IEnumerable<string> remainingQuery { get; set; }
    
}