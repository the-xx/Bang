﻿/************************************************************************************
 *  Copyright © 2014 Meta Company. All Rights Reserved. Use of this software source *
 *  code and binaries requires agreement and compliance with the META Licensed 		*
 *  Application End User License Agreement in the accompanying META EULA.txt file, 	*
 *  which must be included as part of this software for any use. 					*
 ************************************************************************************/

using UnityEngine;
using System.Collections;

namespace Meta.Apps.SDKGuide
{
	public class OnSwipeTestScript : MetaBehaviour
	{
		public void OnSwipeLeft()
		{
			renderer.material.color = Color.red;
		}

		public void OnSwipeRight()
		{
			renderer.material.color = Color.green;
		}
	}
}