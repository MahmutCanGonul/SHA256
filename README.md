# SHA256
Cryptography with SH256  


A cryptographic hash (sometimes called ‘digest’) is a kind of ‘signature’ for a text or a data file. SHA-256 generates an almost-unique 256-bit (32-byte) signature for a text. See below for the source code.




A hash is not ‘encryption’ – it cannot be decrypted back to the original text (it is a ‘one-way’ cryptographic function, and is a fixed size for any size of source text). This makes it suitable when it is appropriate to compare ‘hashed’ versions of texts, as opposed to decrypting the text to obtain the original version.


SHA-256 is one of the successor hash functions to SHA-1 (collectively referred to as SHA-2), and is one of the strongest hash functions available. SHA-256 is not much more complex to code than SHA-1, and has not yet been compromised in any way. The 256-bit key makes it a good partner-function for AES. It is defined in the NIST (National Institute of Standards and Technology) standard ‘FIPS 180-4’. NIST also provide a number of test vectors to verify correctness of implementation. There is a good description at Wikipedia.



With the publication of FIPS PUB 180-2, NIST added three additional hash functions in the SHA family. The algorithms are collectively known as SHA-2, named after their digest lengths (in bits): SHA-256, SHA-384, and SHA-512.

The algorithms were first published in 2001 in the draft FIPS PUB 180-2, at which time public review and comments were accepted. In August 2002, FIPS PUB 180-2 became the new Secure Hash Standard, replacing FIPS PUB 180-1, which was released in April 1995. The updated standard included the original SHA-1 algorithm, with updated technical notation consistent with that describing the inner workings of the SHA-2 family.[4]

In February 2004, a change notice was published for FIPS PUB 180-2, specifying an additional variant, SHA-224, defined to match the key length of two-key Triple DES.[7] In October 2008, the standard was updated in FIPS PUB 180-3, including SHA-224 from the change notice, but otherwise making no fundamental changes to the standard. The primary motivation for updating the standard was relocating security information about the hash algorithms and recommendations for their use to Special Publications 800-107 and 800-57.[8][9][10] Detailed test data and example message digests were also removed from the standard, and provided as separate documents.[11]

In January 2011, NIST published SP800-131A, which specified a move from the then-current minimum of 80-bit security (provided by SHA-1) allowable for federal government use until the end of 2013, to 112-bit security (provided by SHA-2) being both the minimum requirement (starting in 2014) and the recommended security level (starting from the publication date in 2011).[12]

In March 2012, the standard was updated in FIPS PUB 180-4, adding the hash functions SHA-512/224 and SHA-512/256, and describing a method for generating initial values for truncated versions of SHA-512. Additionally, a restriction on padding the input data prior to hash calculation was removed, allowing hash data to be calculated simultaneously with content generation, such as a real-time video or audio feed. Padding the final data block must still occur prior to hash output.[13]

In July 2012, NIST revised SP800-57, which provides guidance for cryptographic key management. The publication disallowed creation of digital signatures with a hash security lower than 112 bits after 2013. The previous revision from 2007 specified the cutoff to be the end of 2010.[10] In August 2012, NIST revised SP800-107 in the same manner.[9]

The NIST hash function competition selected a new hash function, SHA-3, in 2012.[14] The SHA-3 algorithm is not derived from SHA-2.


![image](https://user-images.githubusercontent.com/75094927/132743654-9b3bb8d7-84be-4f0b-958e-605338988a8f.png)


