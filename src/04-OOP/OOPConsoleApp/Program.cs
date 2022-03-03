// <copyright file="Program.cs" company="Jala fundation">
// Copyright (c). All rights reserved.
// </copyright>

Console.WriteLine("Using an analyzer to write better code");
int w = 0;

Console.WriteLine("Testing");
/*
  1 - Add the package StyleCop.Analizers
  2 - Add JSON file called stylecop.json. This fill will be controlling your StyleCop settings.
      // stylecop.json
      {
        "$schema": "https://raw.githubusercontent.com/DotNetAnalyzers/StyleCopAnalyzers/master/StyleCop.Analyzers/StyleCop.Analyzers/Settings/stylecop.schema.json",
        "settings": {
        "orderingRules": {
            "usingDirectivesPlacement": "preserve"
        },
        "documentationRules": {
            "companyName": "Jala fundation",
            "copyrightText": "Copyright (c). All rights reserved."
        }
        }
     }

  3 - Edit the file  *.csjprod. Add this between the project tag.

        <!--Style configuration-->
        <ItemGroup>
            <None Remove="stylecop.json" />
        </ItemGroup>

        <ItemGroup>
            <AdditionalFiles Include="stylecop.json" />
        </ItemGroup>





 */
