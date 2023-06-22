namespace _03._Songs
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine()); // четем брой на песните 

            List<Song> songList = new List<Song>(); // правим колекция от обекти

            for (int i = 0; i < numberOfSongs; i++) // цикъл в който да вземем данните и да ги запишем в обекти
            {
                string[] currentSong = Console.ReadLine().Split("_").ToArray(); // четем стрингов масив от конзолата
                Song newSong = new Song(currentSong[0], currentSong[1], currentSong[2]); // създаваме нов обект в който записваме новата информация
                songList.Add(newSong); // записваме обекта в колекцията обекти          // използвайки конструктор за да сме сигурни, че е подадени всички данни
            }

            string categorySong = Console.ReadLine(); // четем от конзолата типа на песни които да извадим

            foreach (Song curSong in songList) // цикъл който да мине през всеки обект от колекцията от обекти
            {
                if (curSong.TypeList == categorySong) // проверява дали типа отговаря на желаната категория вкарана от конзолата
                {
                    Console.WriteLine(curSong.Name); // принтира името на песента ако категорията е правилната
                }
                else if (categorySong == "all") // ако е алл принтира всичко
                {
                    Console.WriteLine(curSong.Name);

                }
            }
        }
    }

    class Song // създаваме Клас (framework за обекти)
    {
        public Song(string typeList, string name, string time)// създаваме конструктор за класа , който взима определен вид данни и ги записва в пропъртитата на обектите 
        {
            TypeList = typeList; // записва подадената информация от конзолата в пропъртито на обекта
            Name = name;// записва подадената информация от конзолата в пропъртито на обекта
            Time = time;// записва подадената информация от конзолата в пропъртито на обекта
        }

        public string TypeList { get; set; } // инициализираме пропъртитата на обекта

        public string Name { get; set; }// инициализираме пропъртитата на обекта

        public string Time { get; set; }// инициализираме пропъртитата на обекта
    }
}