namespace RubixCube.Model
{
    public sealed class RubixCubeBackFace : RubixCubeFrontOrBackFace
    {
        internal RubixCubeBackFace()
            : base("BackFace.")
        {
        }

        internal RubixCubeBackFace Clone()
        {
            RubixCubeBackFace newFace = new RubixCubeBackFace();
            Clone(newFace);
            return newFace;
        }

        internal RubixCubeLeftFace MoveToLeft()
        {
            RubixCubeLeftFace newFace = new RubixCubeLeftFace();
            RotateAnticlockwiseThroughTop(newFace);
            return newFace;
        }

        internal RubixCubeRightFace MoveToRight()
        {
            RubixCubeRightFace newFace = new RubixCubeRightFace();
            RotateClockwiseThroughTop(newFace);
            return newFace;
        }

        internal RubixCubeTopFace MoveToTop()
        {
            RubixCubeTopFace newFace = new RubixCubeTopFace();
            RotateClockwiseThroughLeft(newFace);
            return newFace;
        }

        internal RubixCubeBottomFace MoveToBottom()
        {
            RubixCubeBottomFace newFace = new RubixCubeBottomFace();
            RotateAnticlockwiseThroughLeft(newFace);
            return newFace;
        }

        internal RubixCubeBackFace RotateClockwise()
        {
            RubixCubeBackFace newFace = new RubixCubeBackFace();
            RotateClockwiseThroughCenterCube(newFace);
            return newFace;
        }

        internal RubixCubeBackFace RotateAnticlockwise()
        {
            RubixCubeBackFace newFace = new RubixCubeBackFace();
            RotateAntiClockwiseThroughCenterCube(newFace);
            return newFace;
        }
    }
}
