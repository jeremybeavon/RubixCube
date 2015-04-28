namespace RubixCube.Model
{
    public sealed class RubixCubeBottomFace : RubixCubeTopOrBottomFace
    {
        internal RubixCubeBottomFace()
            : base("BottomFace.")
        {
        }

        internal RubixCubeFrontFace MoveToFront()
        {
            RubixCubeFrontFace newFace = new RubixCubeFrontFace();
            RotateClockwiseThroughLeft(newFace);
            return newFace;
        }

        internal RubixCubeBackFace MoveToBack()
        {
            RubixCubeBackFace newFace = new RubixCubeBackFace();
            RotateAnticlockwiseThroughLeft(newFace);
            return newFace;
        }

        internal RubixCubeLeftFace MoveToLeft()
        {
            RubixCubeLeftFace newFace = new RubixCubeLeftFace();
            RotateClockwiseThroughFront(newFace);
            return newFace;
        }

        internal RubixCubeRightFace MoveToRight()
        {
            RubixCubeRightFace newFace = new RubixCubeRightFace();
            RotateAnticlockwiseThroughFront(newFace);
            return newFace;
        }

        internal RubixCubeBottomFace RotateClockwise()
        {
            RubixCubeBottomFace newFace = new RubixCubeBottomFace();
            RotateClockwiseThroughCenterCube(newFace);
            return newFace;
        }

        internal RubixCubeBottomFace RotateAnticlockwise()
        {
            RubixCubeBottomFace newFace = new RubixCubeBottomFace();
            RotateAntiClockwiseThroughCenterCube(newFace);
            return newFace;
        }

        internal RubixCubeBottomFace Clone()
        {
            RubixCubeBottomFace newFace = new RubixCubeBottomFace();
            Clone(newFace);
            return newFace;
        }
    }
}
