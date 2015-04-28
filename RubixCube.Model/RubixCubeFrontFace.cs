namespace RubixCube.Model
{
    public sealed class RubixCubeFrontFace : RubixCubeFrontOrBackFace
    {
        internal RubixCubeFrontFace()
            : base("FrontFace.")
        {
        }

        internal RubixCubeFrontFace Clone()
        {
            RubixCubeFrontFace newFace = new RubixCubeFrontFace();
            Clone(newFace);
            return newFace;
        }

        internal RubixCubeLeftFace MoveToLeft()
        {
            RubixCubeLeftFace newFace = new RubixCubeLeftFace();
            RotateClockwiseThroughTop(newFace);
            return newFace;
        }

        internal RubixCubeRightFace MoveToRight()
        {
            RubixCubeRightFace newFace = new RubixCubeRightFace();
            RotateAnticlockwiseThroughTop(newFace);
            return newFace;
        }

        internal RubixCubeTopFace MoveToTop()
        {
            RubixCubeTopFace newFace = new RubixCubeTopFace();
            RotateAnticlockwiseThroughLeft(newFace);
            return newFace;
        }

        internal RubixCubeBottomFace MoveToBottom()
        {
            RubixCubeBottomFace newFace = new RubixCubeBottomFace();
            RotateClockwiseThroughLeft(newFace);
            return newFace;
        }

        internal RubixCubeFrontFace RotateClockwise()
        {
            RubixCubeFrontFace newFace = new RubixCubeFrontFace();
            RotateClockwiseThroughCenterCube(newFace);
            return newFace;
        }

        internal RubixCubeFrontFace RotateAnticlockwise()
        {
            RubixCubeFrontFace newFace = new RubixCubeFrontFace();
            RotateAntiClockwiseThroughCenterCube(newFace);
            return newFace;
        }
    }
}
