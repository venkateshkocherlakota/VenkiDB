using TaskStatus = VenkiDB.Internals.Core.Enum.TaskStatus;

namespace VenkiDB.Internals.FileSystem.Interfaces;

public interface IBlockHandler
{
	/// <summary>
	/// Reads a block of data from dbfile
	/// </summary>
	/// <param name="blockId">Block Id to read data from</param>
	/// <returns>Returns the block data in binary format</returns>
	byte[] ReadBlock(int blockId);
    /// <summary>
    /// Writes given data to specified block
    /// </summary>
    /// <param name="blockId">Block Id to write data to</param>
    /// <param name="blockData">Data to write to in binary format</param>
    /// <param name="overWrite">If true overwrites data even if the block is occupied. If false, throws an exception if block already occupied.</param>
    /// <returns>Task Completion Status</returns>
    TaskStatus WriteBlock(int blockId, byte[] blockData, bool overWrite);
    /// <summary>
    /// Release occupied block so new data can be stored in it
    /// </summary>
    /// <param name="blockId">Block Id to be released</param>
    /// <returns>Task Completion Status</returns>
    TaskStatus ReleaseBlock(int blockId);
}

