﻿using Assets.Scripts.Controllers;
using Assets.Scripts.Managers;
using UnityEngine;

namespace Assets.Scripts.Models.Triggers
{
	class LeftCornerTileTrigger
		: MonoBehaviour
	{
		private void OnTriggerEnter(Collider other)
		{
			if (other.GetComponent<PlayerController>() != null) {
				TileManager.Instance.AddRandomTile();
			}
		}
	}
}
