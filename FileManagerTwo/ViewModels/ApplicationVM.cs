namespace FileManagerTwo
{
    /* Make separate controls for drives list, active directory.
     * Display all drives but if not ready then opactiy is lower
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
