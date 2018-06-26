
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BalancingData
{
	public class Row
	{
		public string points;
		public string time;

	}

	List<Row> rowList = new List<Row>();
	bool isLoaded = false;

	public bool IsLoaded()
	{
		return isLoaded;
	}

	public List<Row> GetRowList()
	{
		return rowList;
	}

	public void Load(TextAsset csv)
	{
		rowList.Clear();
		string[][] grid = CsvParser2.Parse(csv.text);
		for(int i = 1 ; i < grid.Length ; i++)
		{
			Row row = new Row();
			row.points = grid[i][0];
			row.time = grid[i][1];

			rowList.Add(row);
		}
		isLoaded = true;
	}

	public int NumRows()
	{
		return rowList.Count;
	}

	public Row GetAt(int i)
	{
		if(rowList.Count <= i)
			return null;
		return rowList[i];
	}

	public Row Find_points(string find)
	{
		return rowList.Find(x => x.points == find);
	}
	public List<Row> FindAll_points(string find)
	{
		return rowList.FindAll(x => x.points == find);
	}
	public Row Find_time(string find)
	{
		return rowList.Find(x => x.time == find);
	}
	public List<Row> FindAll_time(string find)
	{
		return rowList.FindAll(x => x.time == find);
	}

}