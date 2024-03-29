﻿using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;

namespace Encryptor
{
	public class BCEngine
	{
		private readonly Encoding _encoding;
		private readonly IBlockCipher _blockCipher;
		private PaddedBufferedBlockCipher _cipher;
		private IBlockCipherPadding _padding;

		public BCEngine(Encoding encoding)
		{
			_blockCipher = new AesEngine();
			_encoding = encoding;
		}

		public void SetPadding(IBlockCipherPadding padding)
		{
			if (padding != null)
				_padding = padding;
		}

		public string Encrypt(string plain, string key)
		{
			byte[] result = BouncyCastleCrypto(true, _encoding.GetBytes(plain), key);
			return Convert.ToBase64String(result);
		}

		public string Decrypt(string cipher, string key)
		{
			if (cipher == null) { return null; }

			byte[] result = BouncyCastleCrypto(false, Convert.FromBase64String(cipher), key);
			return _encoding.GetString(result);
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="forEncrypt"></param>
		/// <param name="input"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="CryptoException"></exception>
		private byte[] BouncyCastleCrypto(bool forEncrypt, byte[] input, string key)
		{
			try
			{
				_cipher = _padding == null ? new PaddedBufferedBlockCipher(_blockCipher) : new PaddedBufferedBlockCipher(_blockCipher, _padding);
				byte[] keyByte = _encoding.GetBytes(key);
				_cipher.Init(forEncrypt, new KeyParameter(keyByte));
				return _cipher.DoFinal(input);
			}
			catch (Org.BouncyCastle.Crypto.CryptoException ex)
			{
				throw new CryptoException(ex.Message);
			}
		}
	}
}