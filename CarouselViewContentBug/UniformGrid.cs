namespace CarouselViewContentBug
{
    public class UniformGrid : Grid
    {
        protected override void OnChildAdded(Element child)
        {
            base.OnChildAdded(child);
            Refresh();
        }

        protected override void OnChildRemoved(Element child, int oldLogicalIndex)
        {
            base.OnChildRemoved(child, oldLogicalIndex);
            Refresh();
        }

        void Refresh()
        {
            var columns = ColumnDefinitions.Count;
            var rows = RowDefinitions.Count;

            var childCount = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    var child = Children.ElementAtOrDefault(childCount);

                    if (child is not null)
                    {
                        SetRow(child, r);
                        SetColumn(child, c);
                    }

                    childCount++;
                }
            }
        }
    }
}