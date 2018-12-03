﻿using Olive;
using System.Text;

namespace OliveGenerator
{
    internal class ReadmeFileGenerator
    {
        internal static string Generate()
        {
            var r = new StringBuilder();
            r.AppendLine();

            r.AppendLine($"The {Context.EndPointNamespaceType.FullName}.EndPoint package is generated by « Olive Data End Point Generator ».");
            r.AppendLine();

            r.AppendLine("To learn how to use it, visit: https://geeksltd.github.io/Olive/#/Api/Replication");
            r.AppendLine();
            r.AppendLine();

            r.AppendLine(GenerateQuickReference());

            return r.ToString();
        }

        static string GenerateQuickReference()
        {
            var r = new StringBuilder();
            r.AppendLine("HOW TO USE?");
            r.AppendLine("-------------------");
            r.AppendLine();

            r.AppendLine($"This package will be referenced by the Website project in the consumer service ({Context.EndPointName.Remove("EndPoint")} microservice).");
            r.AppendLine("In the Startup.cs file to kick start the engine, it should call:");
            r.AppendLine();
            r.AppendLine("public override async Task OnStartUpAsync(IApplicationBuilder app)");
            r.AppendLine("{");
            r.AppendLine("await base.OnStartUpAsync(app);");
            r.AppendLine($"await {Context.EndPointNamespaceType.Name}.{Context.EndPointName}.Subscribe();");
            r.AppendLine("}");
            r.AppendLine();

            return r.ToString();
        }
    }
}