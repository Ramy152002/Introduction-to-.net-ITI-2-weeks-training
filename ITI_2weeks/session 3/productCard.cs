namespace session_3
{
    public struct productCard // light weighted short lived object
    {
        public productCard(string name, byte size, string color)
        {
            Name = name;
            Size = size;
            Color = color;
        }

        public string Name { get; set; }
        public byte Size { get; set; }
        public string Color { get; set; }

        public string GetCard()
        {
            return $"Name\t:{Name}\nSize\t:{Size}\n" +
                $"Color\t:{Color}";
        }

    }
}
