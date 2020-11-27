using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ResearchTeamCollection collection1 = new ResearchTeamCollection();
            ResearchTeamCollection collection2 = new ResearchTeamCollection();
            TeamsJournal journal1 = new TeamsJournal();
            TeamsJournal journal2 = new TeamsJournal();

            collection1.ResearchTeamAdded += journal1.TeamEventHandler;
            collection1.ResearchTeamInserted += journal1.TeamEventHandler;

            collection1.ResearchTeamAdded += journal2.TeamEventHandler;
            collection1.ResearchTeamInserted += journal2.TeamEventHandler;

            collection2.ResearchTeamAdded += journal2.TeamEventHandler;
            collection2.ResearchTeamInserted += journal2.TeamEventHandler;

            collection1.AddDefaults();
            collection1.AddResearchTeams(new ResearchTeam("Chaos","IRE",1,TimeFrame.Year));
            collection2.AddDefaults();
            collection2.InsertAt(1, new ResearchTeam("Another", "IRE", 1, TimeFrame.Year));
            collection2.InsertAt(6, new ResearchTeam("Another", "IRE", 1, TimeFrame.Year));

            Console.WriteLine(journal1.ToString());
            Console.WriteLine();
            Console.WriteLine(journal2.ToString());
            */
            // задание 1
            ResearchTeam researchTeam = new ResearchTeam();
            ResearchTeam researchTeam1 = researchTeam.DeepCopy();
            Console.WriteLine(researchTeam.ToString());
            Console.WriteLine(researchTeam1.ToString());

            // задание 2

            Console.Write("Введите имя файла: ");
            string filename = Console.ReadLine();

            if(File.Exists(filename))
            {
                researchTeam.Load(filename);
            }
            else
            {
                Console.WriteLine("Такого файла не существует");
                FileInfo file = new FileInfo(filename);
                StreamWriter sw = file.CreateText();
            }

            // задание 3
            Console.WriteLine(researchTeam.ToString());

            // задание 4

            researchTeam.AddFromConsole();
            researchTeam.Save(filename);
            Console.WriteLine(researchTeam.ToString());

            // задание 5

            ResearchTeam.Load(filename, researchTeam);
            researchTeam.AddFromConsole();
            ResearchTeam.Save(filename, researchTeam);

            // задание 6

            Console.WriteLine(researchTeam.ToString());
            Console.ReadKey();
        }
    }
}
