internal class ThemeManager
{
    public List<Theme> Temas = new List<Theme>{
            new Theme
            {
                nome = "Roxo",
                primary = Color.FromArgb(0, 0, 64),
                secondary = Color.Navy,
                tertiary = Color.Indigo,
                highlight = Color.BlueViolet,
                textPrimary = Color.White,
                textSecondary = Color.FromArgb(200, 200, 255)
            },
            new Theme
            {
                nome = "Escuro",
                primary = Color.FromArgb(18, 18, 18),
                secondary = Color.FromArgb(30, 30, 30),
                tertiary = Color.FromArgb(45, 45, 48),
                highlight = Color.FromArgb(0, 122, 204),
                textPrimary = Color.White,
                textSecondary = Color.FromArgb(170, 170, 170)
            },
            new Theme
            {
                nome = "Claro",
                primary = Color.FromArgb(245, 245, 245),
                secondary = Color.White,
                tertiary = Color.FromArgb(225, 228, 235),
                highlight = Color.FromArgb(0, 120, 215),
                textPrimary = Color.FromArgb(30, 30, 30),
                textSecondary = Color.FromArgb(100, 100, 100)
            },
            new Theme
            {
                nome = "Gamer",
                primary = Color.FromArgb(10, 10, 15),
                secondary = Color.FromArgb(20, 25, 20),
                tertiary = Color.FromArgb(15, 40, 20),
                highlight = Color.FromArgb(0, 200, 80),
                textPrimary = Color.FromArgb(220, 255, 220),
                textSecondary = Color.FromArgb(120, 200, 140)
            },
            new Theme
            {
                nome = "Vermelho",
                primary = Color.FromArgb(25, 5, 5),
                secondary = Color.FromArgb(50, 10, 15),
                tertiary = Color.FromArgb(80, 10, 20),
                highlight = Color.Crimson,
                textPrimary = Color.White,
                textSecondary = Color.FromArgb(240, 180, 180)
            },
            new Theme
            {
                nome = "Oceano",
                primary = Color.FromArgb(5, 25, 35),
                secondary = Color.FromArgb(10, 45, 60),
                tertiary = Color.FromArgb(15, 65, 85),
                highlight = Color.FromArgb(0, 170, 190),
                textPrimary = Color.White,
                textSecondary = Color.FromArgb(160, 215, 225)
            }
            };


    public class Theme
    {
        public string nome { get; set; }
        public Color primary { get; set; }
        public Color secondary { get; set; }
        public Color tertiary { get; set; }
        public Color highlight { get; set; }
        public Color textPrimary { get; set; }
        public Color textSecondary { get; set; }
    }
}