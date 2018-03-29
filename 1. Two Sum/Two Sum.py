#!/usr/bin/env python3
# -*- coding: utf-8 -*-
class Solution:
	def twoSum(self, nums, target):
		"""
		:type nums: List[int]
		:type target: int
		:rtype: List[int]
		"""
		m = {}
		for i, n in enumerate(nums):
			x = target - n
			if x in m:
				return [m[x], i]
			else:
				m[n] = i
		raise ValueError("没找到")
# Runtime: 44 ms
