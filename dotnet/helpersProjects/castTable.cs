// PARA / DE	byte	short	   char	   int	 long	   float	double
// byte	      ----	 Impl.	(char)	 Impl. Impl.	 Impl.	Impl.
// short	   (byte)	 ----	  (char)	 Impl. Impl.	 Impl.	Impl.
// char	     (byte)	(short)	 ----	   Impl. Impl.	 Impl.	Impl.
// int	     (byte)	(short)	(char)	 ----	 Impl.	 Impl.	Impl.
// long	     (byte)	(short)	(char)	(int)	 ----	   Impl.	Impl.
// float	   (byte)	(short)	(char)	(int)	 (long)	 ----	  Impl.
// double	   (byte)	(short)	(char)	(int)	 (long)	(float)	----