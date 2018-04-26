#!/usr/bin/env python3
# -*- coding: utf-8 -*-
class Solution:
	def convert(self, s, numRows):
		"""
		:type s: str
		:type numRows: int
		:rtype: str
		"""
		if numRows == 1:
			return s
		j = 0
		flag = 1
		m = [""] * numRows
		for c in s:
			m[j] += c
			if j == 0:
				flag = 1
			elif j == numRows - 1:
				flag = -1
			j += flag
		ans = ""
		for x in m:
			ans += x
		return ans
# Runtime: 92 ms