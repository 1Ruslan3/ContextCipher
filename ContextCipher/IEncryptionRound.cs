namespace ContextCipher
{
    public interface IEncryptionRound
    {
        byte[] EncryptRound(byte[] inputBlock, byte[] roundKey);
    }
}