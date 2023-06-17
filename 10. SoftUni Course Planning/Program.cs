namespace _10._SoftUni_Course_Planning
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessonsList = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "course start")
            {
                bool IsFirstExercise = true;

                string[] cmdArgs = command.Split(":").ToArray();

                if (cmdArgs[0] == "Add")
                {
                    string lessonTitle = cmdArgs[1];

                    if (!lessonsList.Contains(lessonTitle))
                    {
                        lessonsList.Add(lessonTitle);
                    }

                }
                else if (cmdArgs[0] == "Insert")
                {
                    string lessonTitle = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);

                    if (!lessonsList.Contains(lessonTitle))
                    {
                        lessonsList.Insert(index, lessonTitle);
                    }


                }
                else if (cmdArgs[0] == "Remove")
                {
                    string lessonTitle = cmdArgs[1];

                    if (lessonsList.Contains(lessonTitle))
                    {
                        lessonsList.Remove(lessonTitle);
                    }

                }
                else if (cmdArgs[0] == "Swap")
                {
                    string lessonTitle1 = cmdArgs[1];
                    string lessonTitle2 = cmdArgs[2];
                    int indexTitle1 = lessonsList.IndexOf(lessonTitle1);
                    int indexTitle2 = lessonsList.IndexOf(lessonTitle2);

                    if (lessonsList.Contains(lessonTitle1) && lessonsList.Contains(lessonTitle2))
                    {
                        if (lessonsList.Contains(lessonTitle1 + "-Exercise"))
                        {
                            lessonsList.Remove(lessonTitle1 + "-Exercise");
                            lessonsList.Insert(indexTitle2,lessonTitle1 + "-Exercise");
                        }

                        if (lessonsList.Contains(lessonTitle2 + "-Exercise"))
                        {
                            lessonsList.Remove(lessonTitle2 + "-Exercise");
                            lessonsList.Insert(indexTitle1,lessonTitle2 + "-Exercise");
                        }

                            lessonsList.Remove(lessonTitle1);
                            lessonsList.Remove(lessonTitle2);
                            lessonsList.Insert(indexTitle1, lessonTitle2);
                            lessonsList.Insert(indexTitle2, lessonTitle1);
                        

                    }

                }
                else if (cmdArgs[0] == "Exercise") 
                {
                    string lessonTitle = cmdArgs[1];
                    string lessonExercise = lessonTitle + "-Exercise";
                    int index = lessonsList.IndexOf(lessonTitle);

                    if (lessonsList.Contains(lessonTitle) && IsFirstExercise)
                    {

                        lessonsList.Remove(lessonTitle);
                        lessonsList.Insert(index, lessonExercise);
                    }
                    else if (!lessonsList.Contains(lessonTitle)) 
                    {
                        lessonsList.Add(lessonTitle);
                        lessonsList.Add(lessonExercise);
                    }
                }

            }

            for (int i = 0; i < lessonsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessonsList[i]}");
            }
        }
    }
}