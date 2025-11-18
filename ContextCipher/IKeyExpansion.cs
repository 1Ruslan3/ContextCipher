namespace ContextCipher
{
    public interface IKeyExpansion
    {
        byte[][] ExpandKey(byte[] key);
    }

}