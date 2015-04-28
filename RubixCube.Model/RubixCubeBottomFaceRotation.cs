namespace RubixCube.Model
{
    internal class RubixCubeBottomFaceRotation
    {
        private readonly RubixCubeBottomFace newBottomFace;
        private readonly RubixCubeFrontFace oldFrontFace;
        private readonly RubixCubeFrontFace newFrontFace;
        private readonly RubixCubeLeftFace oldLeftFace;
        private readonly RubixCubeLeftFace newLeftFace;
        private readonly RubixCubeRightFace oldRightFace;
        private readonly RubixCubeRightFace newRightFace;
        private readonly RubixCubeBackFace oldBackFace;
        private readonly RubixCubeBackFace newBackFace;

        public RubixCubeBottomFaceRotation(RubixCube cube, RubixCubeBottomFace newBottomFace)
        {
            this.newBottomFace = newBottomFace;
            oldFrontFace = cube.FrontFace;
            newFrontFace = oldFrontFace.Clone();
            oldLeftFace = cube.LeftFace;
            newLeftFace = oldLeftFace.Clone();
            oldRightFace = cube.RightFace;
            newRightFace = oldRightFace.Clone();
            oldBackFace = cube.BackFace;
            newBackFace = oldBackFace.Clone();
            UpdateFaces();
            RemoveOldCubes();
            AddNewCubes();
        }

        public RubixCubeFrontFace NewFrontFace
        {
            get { return newFrontFace; }
        }

        public RubixCubeLeftFace NewLeftFace
        {
            get { return newLeftFace; }
        }

        public RubixCubeRightFace NewRightFace
        {
            get { return newRightFace; }
        }

        public RubixCubeBackFace NewBackFace
        {
            get { return newBackFace; }
        }

        private void UpdateFaces()
        {
            newFrontFace.BottomLeftCube = newBottomFace.FrontLeftCube;
            newFrontFace.BottomCube = newBottomFace.FrontCube;
            newFrontFace.BottomRightCube = newBottomFace.FrontRightCube;
            newLeftFace.FrontBottomCube = newBottomFace.FrontLeftCube;
            newLeftFace.BottomCube = newBottomFace.LeftCube;
            newLeftFace.BackBottomCube = newBottomFace.BackLeftCube;
            newRightFace.FrontBottomCube = newBottomFace.FrontRightCube;
            newRightFace.BottomCube = newBottomFace.RightCube;
            newRightFace.BackBottomCube = newBottomFace.BackRightCube;
            newBackFace.BottomLeftCube = newBottomFace.BackLeftCube;
            newBackFace.BottomCube = newBottomFace.BackCube;
            newBackFace.BottomRightCube = newBottomFace.BackRightCube;
        }

        private void RemoveOldCubes()
        {
            oldFrontFace.BottomLeftCube.RemoveCubeWith2Faces(oldFrontFace.LeftCube);
            oldFrontFace.CenterCube.RemoveCubeWith2Faces(oldFrontFace.BottomCube);
            oldFrontFace.BottomRightCube.RemoveCubeWith2Faces(oldFrontFace.RightCube);
            oldLeftFace.CenterCube.RemoveCubeWith2Faces(oldLeftFace.BottomCube);
            oldRightFace.CenterCube.RemoveCubeWith2Faces(oldRightFace.BottomCube);
            oldBackFace.BottomLeftCube.RemoveCubeWith2Faces(oldBackFace.LeftCube);
            oldBackFace.CenterCube.RemoveCubeWith2Faces(oldBackFace.BottomCube);
            oldBackFace.BottomRightCube.RemoveCubeWith2Faces(oldBackFace.RightCube);
        }

        private void AddNewCubes()
        {
            newFrontFace.BottomLeftCube.AddCubeWith2Faces(newFrontFace.LeftCube);
            newFrontFace.CenterCube.AddCubeWith2Faces(newFrontFace.BottomCube);
            newFrontFace.BottomRightCube.AddCubeWith2Faces(newFrontFace.RightCube);
            newLeftFace.CenterCube.AddCubeWith2Faces(newLeftFace.BottomCube);
            newRightFace.CenterCube.AddCubeWith2Faces(newRightFace.BottomCube);
            newBackFace.BottomLeftCube.AddCubeWith2Faces(newBackFace.LeftCube);
            newBackFace.CenterCube.AddCubeWith2Faces(newBackFace.BottomCube);
            newBackFace.BottomRightCube.AddCubeWith2Faces(newBackFace.RightCube);
        }
    }
}
