using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    class SoloArtist : ArtistMusician
    {

        string bandstatus;
        string Bandstatus //состоит ли этот артист в какой-либо группе помимо его соло деятельности
        {
            get
            {
                return bandstatus;
            }
            set
            {
                if (bandstatus == "yes" || bandstatus == "no" || bandstatus == "да" || bandstatus == "нет")
                {
                    value = bandstatus;
                }
                else throw new Exception("Варианты только да/нет yes/no");
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
        int collabs;
        int Collabs
        {
            get
            {
                return collabs;
            }
            set
            {
                if (collabs >= 0) value = collabs;
                else throw new Exception("Количество не может быть меьше нуля.");
            }
        }
        string nameoftheband = "";

        public SoloArtist(string name, DateTime debut, string bandstatus) : base(name, debut)
        {
            this.name = name;
            this.debut = debut;
            this.bandstatus = bandstatus;
        }

        public SoloArtist(string name, DateTime debut, string bandstatus, int albums, int soloreleases, int collabs) : this(name, debut, bandstatus)
        {
            this.name = name;
            this.debut = debut;
            this.bandstatus = bandstatus;
            this.albums = albums;
            this.soloreleases = soloreleases;
            this.collabs = collabs;
        }

        public override void Info()
        {
            Console.WriteLine("Имя артиста: " + name);
            Console.WriteLine("Дата дебюта: " + debut);
            if ((bandstatus == "yes" || bandstatus == "да" || bandstatus == "Yes" || bandstatus == "Да") && nameoftheband != "")
            {
                Console.WriteLine("Артист также состоит в группе: " + nameoftheband);
            }
        }

        public override void Discography()
        {
            Console.WriteLine("Дискография артиста: ");
            Console.WriteLine("Количество выпущенных альбомов: " + albums);
            Console.WriteLine("Количество соло-релизов: " + soloreleases);
            Console.WriteLine("Количество коллабораций с другими артистами: " + collabs);
        }

        public void SideActivity()
        {
            if (bandstatus == "yes" || bandstatus == "да" || bandstatus == "Yes" || bandstatus == "Да")
            {
                Console.WriteLine("Введите название группы, в которой состоит артист: ");
                this.nameoftheband = Console.ReadLine();
            }
            else Console.WriteLine("Артист не состит ни в каких группах.");
        }

    }
}
