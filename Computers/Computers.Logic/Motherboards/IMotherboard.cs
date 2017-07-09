namespace Computers.Logic
{
    public interface IMotherboard
    {
        /// <summary>
        /// Loads value from the Ram
        /// </summary>
        /// <returns>The loaded value</returns>
        int LoadRamValue();

        /// <summary>
        /// Saves the given value
        /// </summary>
        /// <param name="value">Saved value</param>
        void SaveRamValue(int value);
   
        /// <summary>
        /// Draws text on video card
        /// </summary>
        /// <param name="data">The text to draw</param>
        void DrawOnVideoCard(string data);
    }
}
