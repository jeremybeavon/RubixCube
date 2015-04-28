namespace RubixCube.Model
{
    public sealed class RubixCubeTopFace : RubixCubeTopOrBottomFace
    {
        internal RubixCubeTopFace()
            : base("TopFace.")
        {
        }

        internal RubixCubeFrontFace MoveToFront()
        {
            RubixCubeFrontFace newFace = new RubixCubeFrontFace();
            RotateAnticlockwiseThroughLeft(newFace);
            return newFace;
        }

        internal RubixCubeBackFace MoveToBack()
        {
            RubixCubeBackFace newFace = new RubixCubeBackFace();
            RotateClockwiseThroughLeft(newFace);
            return newFace;
        }

        internal RubixCubeLeftFace MoveToLeft()
        {
            RubixCubeLeftFace newFace = new RubixCubeLeftFace();
            RotateAnticlockwiseThroughFront(newFace);
            return newFace;
        }

        internal RubixCubeRightFace MoveToRight()
        {
            RubixCubeRightFace newFace = new RubixCubeRightFace();
            RotateClockwiseThroughFront(newFace);
            return newFace;
        }

        internal RubixCubeTopFace RotateClockwise()
        {
            RubixCubeTopFace newFace = new RubixCubeTopFace();
            RotateClockwiseThroughCenterCube(newFace);
            return newFace;
        }

        internal RubixCubeTopFace RotateAnticlockwise()
        {
            RubixCubeTopFace newFace = new RubixCubeTopFace();
            RotateAntiClockwiseThroughCenterCube(newFace);
            return newFace;
        }

        internal RubixCubeTopFace Clone()
        {
            RubixCubeTopFace newFace = new RubixCubeTopFace();
            Clone(newFace);
            return newFace;
        }
    }
}
