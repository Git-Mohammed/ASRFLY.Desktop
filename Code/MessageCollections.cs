using ASRFLY.Desktop.Properties;
namespace ASRFLY.Desktop.Code
{
    internal static class MessageCollections
    {
        // message
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // dialog
    }
}
