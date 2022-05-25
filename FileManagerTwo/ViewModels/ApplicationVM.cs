using System.Collections.Generic;
using System.Windows.Media;

namespace FileManagerTwo
{
    /* Make separate controls for drives list, active directory.
     * Display all drives but if not ready then opacity is lower
     * NEW GUI
     * 
     * Popup: Delete
     * Popup: Copy
     * Popup: Paste
     * Popup: Properties
     * 
     * Drag and drop files
     * 
     * */
    public class ApplicationVM
    {
        public FileBrowserVM FileBrowserLeftVM { get; set; }
        public FileBrowserVM FileBrowserRightVM { get; set; }

        public ApplicationVM()
        {
            FileBrowserLeftVM = new FileBrowserVM();
            FileBrowserRightVM = new FileBrowserVM();


            var f = new List<string>();
            // Enumerate the current set of system fonts,
            // and fill the combo box with the names of the fonts.
            foreach (FontFamily fontFamily in Fonts.SystemFontFamilies)
            {
                // FontFamily.Source contains the font family name.
                f.Add(fontFamily.Source);
            }
        }

    }
}
