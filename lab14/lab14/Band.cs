using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    class Band : ArtistMusician
    {

        int members;
        int Members
        {
            get
            {
                return members;
            }
            set
            {
                if (members > 1)
                {
                    value = members;
                }
                else { throw new Exception("В группе должно быть хотя бы 2 участника."); }
            }
        }
        int albums;
        int Albums
        {
            get
            {
                return albums;
            }
            set
            {
                if (albums >= 0) value = albums;
                else throw new Exception("Количество не может быть меьше нуля.");
            }
        }
        int soloreleases;
        int Soloreleases
        {
            get
            {
                return soloreleases;
            }
            set
            {
                if (soloreleases >= 0) value = soloreleases;
                else throw new Exception("Количество не может быть меьше нуля.");
            }
        }
        string names = "";

        public Band(string name, DateTime debut, int members) : base(name, debut)
        {
            this.name = name;
            this.debut = debut;
            this.members = members;
        }

        public Band(string name, DateTime debut, int members, int albums, int soloreleases) : this(name, debut, members)
        {
            this.name = name;
            this.debut = debut;
            this.members = members;
            this.albums = albums;
            this.soloreleases = soloreleases;
        }

        public override void Info()
        {
            Console.WriteLine("Название группы: " + name);
            Console.WriteLine("Дата дебюта: " + debut);
            Console.WriteLine("Количество участликов в группе: " + Members);
            if (names != "") Console.WriteLine("Имена участников: " + names);

        }

        public override void Discography()
        {
            Console.WriteLine("Дискография группы: ");
            Console.WriteLine("Количество выпущенных альбомов: " + Albums);
            Console.WriteLine("Количество соло-релизов: " + Soloreleases);
        }

        public void SetNames()
        {
            Console.WriteLine("Введите имена участников: ");
            string[] notnames = new string[Members];
            for (int i = 0; i < notnames.Length; i++)
            {
                notnames[i] = Console.ReadLine();
            }
            names = String.Join(", ", notnames);
        }

    }
}
