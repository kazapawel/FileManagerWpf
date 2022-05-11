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
        }

    }
}
