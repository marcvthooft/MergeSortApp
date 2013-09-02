using System;

namespace MergeSort.BL
{
	public class Algorithm
	{
		public Algorithm ()
		{
		}

		/// <summary>
		/// Sorteert een array
		/// </summary>
		/// <param name="array">Array.</param>
		/// <param name="lo">Lo.</param> laagste waarde van de array
		/// <param name="n">N.</param> lengte van de array-1
		public static void mergeSort_srt(int [] array,int lo, int n) {
			int low = lo;
			int high = n;
			if (low >= high) {
				return;
			}

			int middle = (low + high) / 2;
			//wanneer left returnt zal right dit ook doen en zal dus verder                                                                                                                           gegaan worden op de vorige left. En andersom.
			//left array
			mergeSort_srt(array, low, middle);
			//right array
			mergeSort_srt(array, middle + 1, high);

			//deze waarden geven het bereik van de linker en rechter helft van de array aan.
			int end_low = middle;
			int start_high = middle + 1;

			while ((lo <= end_low) && (start_high <= high)) {
				if (array[low] < array[start_high]) {
					low++;    //zodat elk getal met elkaar vergeleken wordt. vb. {1 2 3} 1 met 3 en 2 met 3.
				} else {      //wanneer low==start_high, zal dit proces niks veranderen.
					int Temp = array[start_high];
					for (int k = start_high- 1; k >= low; k--) {  //zodat elk getal één plek opschuift.
						array[k+1] = array[k];
					}
					array[low] = Temp;
					low++;
					end_low++;
					start_high++;
				}
			}
		}
	}
}

