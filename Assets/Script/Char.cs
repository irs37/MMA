﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chars {
	public string meme;
	private Stats stat;
	private Skill[] skills;
	private Tag[] tags;
	private Status[] statuses;
	//private int pos;

	Chars(string meme, Stats stat, Skill[] skills, Tag[] tags, Status[] statuses) {
		this.meme = meme;
		this.stat = stat;
		this.skills = skills;
		this.tags = tags;
		this.statuses = statuses;
		//this.pos = 0;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}