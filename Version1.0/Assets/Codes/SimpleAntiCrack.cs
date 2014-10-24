
public class SimpleAntiCrack{

	public const int m_antiKey = 123456;
	 
	public static string EncryptData(string data)
	{
		return m_antiKey^data;
	}
	public static string DecryptData(string data)
	{
		return data ^=m_antiKey;
	}
}
