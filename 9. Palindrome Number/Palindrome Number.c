bool isPalindrome(int x)
{
	if (x < 0)
	{
		return false;
	}
	if (x < 10)
	{
		return true;
	}

	long tmp = x;
	long reverse = 0;
	while (tmp)
	{
		reverse *= 10;
		reverse += tmp % 10;
		tmp /= 10;
	}
	return reverse == x;
}
//Runtime: 184 ms