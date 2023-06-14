using EQC.ProposalV2;
using EQC.ProposalV2.EDMXModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordExportTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // get directory
            var solutionPath = @"..\..\";


            var ExportInstance = new ExportEngRiskInstance(1);
            ExportInstance.Export(
                Path.Combine(solutionPath, @".\output.docx"),
               Path.Combine(solutionPath, @".\template\Test2.docx"),
               Path.Combine(solutionPath, @".\attachment")
            );
        }
    }
}
